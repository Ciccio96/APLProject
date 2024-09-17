#include<iostream>
#include<string>
#include <winsock2.h>
#include <WS2tcpip.h>
#include <C:/ProgettoAPL/libraries/mysql8.4.0-64/include/mysql/jdbc.h>

#pragma warning(disable : 4996)

using namespace std;
using namespace sql;

class Metodi 
{
	public:

        static void effettua_Richiesta(SOCKET acceptSocket, SOCKET serverSocket, Connection* con){
            ResultSet* res;
            if (acceptSocket) {
                int count;
                do {
                    cout << "Metodo: espleta_Richiesta" << endl;
                    Statement* stmt;
                    char receiveBuffer[4096]{};
                    char responseBuffer[4096];

                    // Ricezione richiesta dal client
                    int rbyteCount = recv(acceptSocket, receiveBuffer, sizeof(receiveBuffer), 0);
                    count = rbyteCount;
                    if (rbyteCount < 0) {
                        cout << "Server: richiesta del client invalida " << WSAGetLastError() << endl;
                    }
                    else {
                        stmt = con->createStatement();
                        cout << "Query ricevuta dal client: " <<receiveBuffer << endl;
                        string str(receiveBuffer);
                        if (str.find("update") == 0 || str.find("insert") == 0) {
                            //Caso in cui la richiesta sia una create o una update
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
                            //Caso in cui la richiesta sia una select
                            res = stmt->executeQuery(receiveBuffer);
                            string sendedStr = "";
                            const int length = sendedStr.length();
                            char* char_array = new char[length];
                            int count = res->getMetaData()->getColumnCount();
                            while (res->next()) {
                                for (int i = 1; i <= count; i++) {
                                    sendedStr += (i < count) ? res->getString(i) + "," : res->getString(i) + " +";
                                }
                            }
                            strcpy(char_array, sendedStr.c_str());
                            int sbyteCount = send(acceptSocket, char_array, 4096, 0);

                            if (sbyteCount == SOCKET_ERROR) {
                                cout << "Server: errore invio response " << WSAGetLastError() << endl;
                            }
                            else {
                                send(serverSocket, responseBuffer, strlen(responseBuffer), 0);
                                delete[] char_array;
                            }
                        }
                    }
                    
                } while (count > 0);
            }
        }
};