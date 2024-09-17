#include <iostream>
#include <winsock2.h>
#include <WS2tcpip.h>
#include <string.h>
#pragma once
#pragma comment (lib,"ws2_32.lib")

using namespace std;

class Socket {

public:

    struct Socket_Returned {
        SOCKET acceptSocket, serverSocket;
    };

	static Socket_Returned inizialize_Socket() {

        // Inizializzazione variabili WSA
        WSADATA wsaData;
        int wsaerr;
        WORD wVersionRequested = MAKEWORD(2, 2);
        wsaerr = WSAStartup(wVersionRequested, &wsaData);

        // Si valuta la corretta inizializzazione
        if (wsaerr != 0) {
            cout << "Dll Winsock non trovate!" << endl;
        }

        // Creo nuovo socket
        SOCKET serverSocket;
        serverSocket = INVALID_SOCKET;
        serverSocket = socket(AF_INET, SOCK_STREAM, 0);

        // Check for socket creation success
        if (serverSocket == INVALID_SOCKET) {
            cout << "Errore nella generazione del socket: " << WSAGetLastError() << endl;
            WSACleanup();
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
        }

        // Attesa per nuove connessioni
        if (listen(serverSocket, 1) == SOCKET_ERROR) {
            cout << "Errore ricezione del socket: " << WSAGetLastError() << endl;
        }
        else {
            cout << "Il socket e' attivo e pronto a ricevere nuove connessioni ..." << endl;
            cout << "Metodo: initialize_Socket" << endl;
        }

        // Meccanismo per accettare connessioni

        SOCKET acceptSocket;
        acceptSocket = accept(serverSocket, nullptr, nullptr);

        // Check for successful connection
        if (acceptSocket == INVALID_SOCKET) {
            cout << "Accept fallita: " << WSAGetLastError() << endl;
            WSACleanup();
        }
        else {
            cout << "Comunicazione client/server avviata ..." << endl;
        }

        //Ritorno valori al main

        Socket_Returned result = { acceptSocket, serverSocket };

        return result;
	}
};