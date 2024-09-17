#include <iostream>
#include "../connectionToDb.h"
#include "../metodi.h"
#include "../socketSetting.h"

#pragma warning(disable : 4996)

using namespace std;
using namespace sql;

int main() {
    
    Connection* con = Connect::connect_To_Db();
        
    Socket::Socket_Returned socket = Socket::inizialize_Socket();

    try {            
        int count;
        Metodi::effettua_Richiesta(socket.acceptSocket, socket.serverSocket, con);
    }
    catch (SQLException& e) {
        cout << "ERR:" << e.what() << endl;
        cout << "ERR-code:" << e.getErrorCode() << endl;
        cout << "SQL-state:" << e.getSQLState() << endl;
    }
       
    return 0;
}
