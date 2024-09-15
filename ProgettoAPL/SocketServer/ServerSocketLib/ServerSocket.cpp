//#include <iostream>
//#include <WS2tcpip.h>
//#pragma comment (lib, "ws2_32.lib")
//
//using namespace std;
//
//int main() {
//    // Initialize WSA variables
//    WSADATA wsaData;
//    int wsaerr;
//    WORD wVersionRequested = MAKEWORD(2, 2);
//    wsaerr = WSAStartup(wVersionRequested, &wsaData);
//
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
//    // Continue with the server setup...
//    // (See the full code here: https://github.com/Tharun8951/cpp-tcp-server/")
//
//    return 0;
//
//
//    // Create a socket
//    SOCKET serverSocket;
//    serverSocket = INVALID_SOCKET;
//    serverSocket = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);
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
//    service.sin_addr.s_addr = INADDR_ANY;  // Replace with your desired IP address
//    service.sin_port = htons(45678);  // Choose a port number
//
//    // Use the bind function
//    if (bind(serverSocket, reinterpret_cast<SOCKADDR*>(&service), sizeof(service)) == SOCKET_ERROR) {
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
//    // Receive data from the client
//    char receiveBuffer[200];
//    int rbyteCount = recv(acceptSocket, receiveBuffer, 200, 0);
//    if (rbyteCount < 0) {
//        std::cout << "Server recv error: " << WSAGetLastError() << std::endl;
//        return 0;
//    }
//    else {
//        std::cout << "Received data: " << receiveBuffer << std::endl;
//    }
//
//    // Send a response to the client
//    char buffer[200];
//    std::cout << "Enter the message: ";
//    std::cin.getline(buffer, 200);
//    int sbyteCount = send(acceptSocket, buffer, 200, 0);
//    if (sbyteCount == SOCKET_ERROR) {
//        std::cout << "Server send error: " << WSAGetLastError() << std::endl;
//        return -1;
//    }
//    else {
//        std::cout << "Server: Sent " << sbyteCount << " bytes" << std::endl;
//    }
//}

//#include <iostream>
//#include <WS2tcpip.h>
//#pragma comment (lib, "ws2_32.lib")
//
//using namespace std;
//
//void socket_Programming() {
//
//	//Inizializzazione winsock
//	WSADATA	wsData;
//	WORD ver = MAKEWORD(2, 2);
//
//	int wsOk = WSAStartup(ver, &wsData);
//	if (wsOk != 0) {
//		cerr << "Impossibile inizializzare winsock! Uscita ..." << endl;
//		return;
//	}
//
//	//Creazione socket
//	SOCKET listening = socket(AF_INET, SOCK_STREAM, 0);
//	if (listening == INVALID_SOCKET) {
//		cerr << "Impossibile creare Socket! Uscita ..." << endl;
//		return;
//	}
//
//	//Bind socket (IPAddress & port)
//	sockaddr_in hint;
//	hint.sin_family = AF_INET;
//	hint.sin_port = htons(45678);
//	hint.sin_addr.S_un.S_addr = INADDR_ANY;
//
//	bind(listening, (sockaddr*)&hint, sizeof(hint));
//
//	//Mettiamoci in ascolto del socket
//	listen(listening, SOMAXCONN);
//
//	//Attesa di connessione
//	sockaddr_in client;
//	int clientSize = sizeof(client);
//
//	SOCKET clientSocket = accept(listening, (sockaddr*)&client, &clientSize);
//
//	char host[NI_MAXHOST];
//	char service[NI_MAXHOST];
//
//	ZeroMemory(host, NI_MAXHOST);
//	ZeroMemory(service, NI_MAXHOST);
//	memset(host, 0, NI_MAXHOST);
//
//	if (getnameinfo((sockaddr*)&client, sizeof(client), host, NI_MAXHOST, service, NI_MAXSERV, 0) == 0)
//	{
//		cout << host << "Connesso alla porta-if" << service << endl;
//	}
//	else
//	{
//		inet_ntop(AF_INET, &client.sin_addr, host, NI_MAXHOST);
//		cout << host << "Connesso alla porta-else" << htons(client.sin_port) << endl;
//	}
//
//	//Chiusura ascolto socket 
//	closesocket(listening);
//
//	//Accetta e invia messaggi al client
//	char buf[4096];
//
//	while (true) {
//		ZeroMemory(buf, 4096);
//
//		int bytesReceived = recv(clientSocket, buf, 4096, 0);
//		if (bytesReceived == SOCKET_ERROR)
//		{
//			cerr << "Error in recv()" << endl;
//			break;
//		}
//
//		if (bytesReceived == 0) {
//			cout << "Client disconnesso" << endl;
//			break;
//		}
//
//		send(clientSocket, buf, bytesReceived + 1, 0);
//	}
//
//
//	//Chiusura del socket
//	closesocket(clientSocket);
//
//	//Pulizia winsock
//	WSACleanup;
//}