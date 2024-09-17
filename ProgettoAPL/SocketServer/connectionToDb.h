
#include <C:/ProgettoAPL/libraries/mysql8.4.0-64/include/mysql/jdbc.h>
#pragma once

using namespace std;
using namespace sql;

class Connect {
	public:
		static Connection* connect_To_Db() {
			
			mysql::MySQL_Driver* driver;
			Connection* con;
			driver = mysql::get_mysql_driver_instance();
			con = driver->connect("tcp://127.0.0.1:3306", "root", "francesco");

			con->setSchema("jewelryapp"); //Set del nome del database da utilizzare

			return con;
		}
};