#include <iostream>
#include <winsock2.h>
//#include <C:/ProgettoAPL/libraries/mysql8.4.0-64/include/jdbc/cppconn/driver.h>
//#include <C:/ProgettoAPL/libraries/mysql8.4.0-64/include/jdbc/cppconn/exception.h> 
//#include <C:/ProgettoAPL/libraries/mysql8.4.0-64/include/jdbc/cppconn/statement.h> 
//#include <C:/ProgettoAPL/libraries/mysql8.4.0-64/include/jdbc/mysql_connection.h> 
//#include <C:/ProgettoAPL/libraries/mysql8.4.0-64/include/jdbc/mysql_driver.h>

#include <C:/ProgettoAPL/libraries/mysql8.4.0-64/include/mysql/jdbc.h>
#include <WS2tcpip.h>
using namespace sql;
#pragma comment (lib,"ws2_32.lib")
#pragma warning(disable : 4996)

using namespace std;

int main() {
    
        mysql::MySQL_Driver* driver;
        Connection* con;
        
        const long size_Buffer = 1048576;

        // Inizializzazione variabili WSA
        WSADATA wsaData;
        int wsaerr;
        WORD wVersionRequested = MAKEWORD(2, 2);
        wsaerr = WSAStartup(wVersionRequested, &wsaData);
        driver = mysql::get_mysql_driver_instance();
        con = driver->connect("tcp://127.0.0.1:3306",
            "root", "francesco");

        con->setSchema("jewelryapp"); //Set del nome del database da utilizzare

        // Si valuta la corretta inizializzazione
        if (wsaerr != 0) {
            cout << "Dll Winsock non trovate!" << endl;
            return 0;
        }

        // Creo nuovo socket
        SOCKET serverSocket;
        serverSocket = INVALID_SOCKET;
        serverSocket = socket(AF_INET, SOCK_STREAM, 0);

        // Check for socket creation success
        if (serverSocket == INVALID_SOCKET) {
            cout << "Errore nella generazione del socket: " << WSAGetLastError() << endl;
            WSACleanup();
            return 0;
        }

        // Bind del socket ad un IP address e al numero di porta
        sockaddr_in service;
        service.sin_family = AF_INET;
        service.sin_port = htons(45678);  // Numero di porta scelto (uguale a quello scelto per il client in C#)
        service.sin_addr.S_un.S_addr = INADDR_ANY;

        // Utilizzo della bind function
        if (::bind(serverSocket, reinterpret_cast<SOCKADDR*>(&service), sizeof(service)) == SOCKET_ERROR) {
            cout << "Bind fallita: " << WSAGetLastError() << endl;
            closesocket(serverSocket);
            WSACleanup();
            return 0;
        }

        // Attesa per nuove connessioni
        if (listen(serverSocket, 1) == SOCKET_ERROR) {
            cout << "Errore ricezione del socket: " << WSAGetLastError() << endl;
        }
        else {
            cout << "Il socket e' attivo e pronto a ricevere nuove connessioni ..." << endl;
        }

        // Meccanismo per accettare connessioni

        SOCKET acceptSocket;
        acceptSocket = accept(serverSocket, nullptr, nullptr);

        // Check for successful connection
        if (acceptSocket == INVALID_SOCKET) {
            cout << "Accept fallita: " << WSAGetLastError() << endl;
            WSACleanup();
            return -1;
        }
        else {
            cout << "Comunicazione client/server avviata ..." << endl;
        }
        try {
            ResultSet* res;
            if (acceptSocket) {
                int count;
                do {
                    Statement* stmt;
                    char receiveBuffer[4096]{};
                    //char* receiveBuffer = static_cast<char*>(std::calloc(4096, 1));
                    char responseBuffer[4096];

                    // Ricezione richiesta dal client
                    int rbyteCount = recv(acceptSocket, receiveBuffer, sizeof(receiveBuffer), 0);
                    count = rbyteCount;
                    if (rbyteCount < 0) {
                        cout << "Server: richiesta del client invalida " << WSAGetLastError() << endl;
                        return 0;
                    }
                    else {
                        stmt = con->createStatement();
                        cout << "Query ricevuta dal client: " <<receiveBuffer << endl;
                        string str(receiveBuffer);
                        if (str.find("update") == 0 || str.find("insert") == 0) {
                            stmt->execute(receiveBuffer);
                            string sendedStr = "Ok";
                            const int length = sendedStr.length();
                            char* char_array = new char[length];
                            strcpy(char_array, sendedStr.c_str());
                            int sbyteCount = send(acceptSocket, char_array, 4096, 0);
                            send(serverSocket, responseBuffer, strlen(responseBuffer), 0);
                            delete[] char_array;
                        }
                        else {
                            res = stmt->executeQuery(receiveBuffer);
                            // Invio della response al client
                            string sendedStr = "";
                            const int length = sendedStr.length();
                            char* char_array = new char[length];
                            int count = res->getMetaData()->getColumnCount();
                            while (res->next()) {
                                for (int i = 1; i <= count; i++) {
                                    sendedStr += (i < count) ? res->getString(i) + "," : res->getString(i) + " +";
                                    //sendedStr += (i < count) ? res->getString(i) + "," : (i == count ? res->getString(i) + "+" : res->getString(i));
                                }
                            }
                            strcpy(char_array, sendedStr.c_str());
                            int sbyteCount = send(acceptSocket, char_array, 4096, 0);

                            if (sbyteCount == SOCKET_ERROR) {
                                cout << "Server: errore invio response " << WSAGetLastError() << endl;
                                return -1;
                            }
                            else {
                                send(serverSocket, responseBuffer, strlen(responseBuffer), 0);
                                delete[] char_array;
                            }
                        }
                    }



                } while (count > 0);
            };
        }
        catch (SQLException& e) {
            cout << "ERR:" << e.what() << endl;
            cout << "ERR-code:" << e.getErrorCode() << endl;
            cout << "SQL-state:" << e.getSQLState() << endl;
        }
       
    return 0;
}
