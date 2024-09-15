//
//#include <iostream> 
//#include <winsock2.h>
//#include <cppconn/driver.h> 
//#include <cppconn/exception.h> 
//#include <cppconn/statement.h> 
//#include <mysql_connection.h> 
//#include <mysql_driver.h>
//#include <WS2tcpip.h>
//using namespace sql;
//#pragma comment (lib,"ws2_32.lib")
//#pragma warning(disable : 4996)
//
//using namespace std;
//
//int Socket_Implementation() {
//    // Initialize WSA variables
//    WSADATA wsaData;
//    int wsaerr;
//    WORD wVersionRequested = MAKEWORD(2, 2);
//    wsaerr = WSAStartup(wVersionRequested, &wsaData);
//    // Check for initialization success
//    if (wsaerr != 0) {
//        std::cout << "The Winsock dll not found!" << std::endl;
//        return 0;
//    }
//    else {
//        std::cout << "The Winsock dll found" << std::endl;
//        std::cout << "The status: " << wsaData.szSystemStatus << std::endl;
//    }
//
//    // Create a socket
//    SOCKET serverSocket;
//    serverSocket = INVALID_SOCKET;
//    serverSocket = socket(AF_INET, SOCK_STREAM, 0);
//
//    // Check for socket creation success
//    if (serverSocket == INVALID_SOCKET) {
//        std::cout << "Error at socket(): " << WSAGetLastError() << std::endl;
//        WSACleanup();
//        return 0;
//    }
//    else {
//        std::cout << "Socket is OK!" << std::endl;
//    }
//
//    // Bind the socket to an IP address and port number
//    sockaddr_in service;
//    service.sin_family = AF_INET;
//    service.sin_port = htons(45678);  // Choose a port number
//    service.sin_addr.S_un.S_addr = INADDR_ANY;  // Replace with your desired IP address
//
//    // Use the bind function
//    if (::bind(serverSocket, reinterpret_cast<SOCKADDR*>(&service), sizeof(service)) == SOCKET_ERROR) {
//        std::cout << "bind() failed: " << WSAGetLastError() << std::endl;
//        closesocket(serverSocket);
//        WSACleanup();
//        return 0;
//    }
//    else {
//        std::cout << "bind() is OK!" << std::endl;
//    }
//
//    // Listen for incoming connections
//    if (listen(serverSocket, 1) == SOCKET_ERROR) {
//        std::cout << "listen(): Error listening on socket: " << WSAGetLastError() << std::endl;
//    }
//    else {
//        std::cout << "listen() is OK! I'm waiting for new connections..." << std::endl;
//    }
//
//    // Accept incoming connections
//    SOCKET acceptSocket;
//    acceptSocket = accept(serverSocket, nullptr, nullptr);
//
//    // Check for successful connection
//    if (acceptSocket == INVALID_SOCKET) {
//        std::cout << "accept failed: " << WSAGetLastError() << std::endl;
//        WSACleanup();
//        return -1;
//    }
//    else {
//        std::cout << "accept() is OK!" << std::endl;
//    }
//
//    try {
//        sql::mysql::MySQL_Driver* driver;
//        sql::Connection* con;
//        sql::ResultSet* res;
//        sql::Statement* stmt;
//
//        driver = sql::mysql::get_mysql_driver_instance();
//        con = driver->connect("tcp://127.0.0.1:3306",
//            "root", "francesco");
//
//        con->setSchema("jewelryapp"); // your database name 
//
//        char receiveBuffer[500];
//        char responseBuffer[200];
//
//        // Receive data from the client
//        int rbyteCount = recv(acceptSocket, receiveBuffer, 500, 0);
//        if (rbyteCount < 0) {
//            std::cout << "Server recv error: " << WSAGetLastError() << endl;
//            return 0;
//        }
//        else {
//            stmt = con->createStatement();
//            cout << "Received data: " << receiveBuffer << endl;
//            res = stmt->executeQuery(receiveBuffer);
//        }
//
//        // Send a response to the client
//        string sendedStr = "";
//        const int length = sendedStr.length();
//        char* char_array = new char[length + 1];
//        int count = res->getMetaData()->getColumnCount();
//        while (res->next()) {
//            for (int i = 1; i < count; i++) {
//                sendedStr += (i < count - 1) ? res->getString(i) + "," : res->getString(i);
//            }
//        }
//        strcpy(char_array, sendedStr.c_str());
//        //sendedStr.copy(responseBuffer, sendedStr.length());
//        int sbyteCount = send(acceptSocket, char_array, 200, 0);
//
//
//        if (sbyteCount == SOCKET_ERROR) {
//            std::cout << "Server send error: " << WSAGetLastError() << std::endl;
//            return -1;
//        }
//        else {
//            std::cout << "Server: Sent " << char_array << std::endl;
//            send(serverSocket, responseBuffer, strlen(responseBuffer), 0);
//        }
//
//        delete res;
//        delete stmt;
//        delete con;
//
//    }
//    catch (sql::SQLException& e) {
//        std::cerr << "SQL Error: " << e.what() << std::endl;
//    }
//
//    return 0;
//}
