--------------------------------------------------- SCARICARE CARTELLA DEL PROGETTO -------------------------------------------------

Per scaricare il progetto recarsi al seguente path: https://github.com/Ciccio96/APLProject.git ed effettuarne il download
Probabilmente git aggiunge al nome della cartella il suffisso -main (es. APLProject-main) --> eliminare il suffisso -main
Una volta scaricato posizionare la cartella ProgettoAPL (che si trova all'interno di APLProject) come al path seguente: C:\APLProject\ProgettoAPL (condizione necessaria)

--------------------------------------------------------------------------------------------------------------------------------------


Settaggio parametri per il funzionamento dell'applicazione

--------------------------------------------------- DATABASE ------------------------------------------------

Scaricare MySql Installer per ottenere MySql Server e Workbench .... poi creare un nuovo database (approccio in locale)

			Nome: Local
			Hostname: 127.0.0.1
			Port: 3306
			Username: root
			Password: francesco

Creiamo database con la seguente query e lo scegliamo:

			CREATE DATABASE jewelryapp;
			USE jewelryapp;

A questo punto creiamo due tabelle di prova:

			CREATE TABLE IF NOT EXISTS Cliente (
				Id VARCHAR(36) NOT NULL PRIMARY KEY,
				Tipologia INT NOT NULL,
				Nome VARCHAR(255) NOT NULL,
				Cognome VARCHAR(255) NOT NULL,
				Email VARCHAR(255) NOT NULL,
				Password VARCHAR(255) NOT NULL,
				TipoPreferito INT NOT NULL,
				MaterialePreferito INT NOT NULL
			);

			CREATE TABLE IF NOT EXISTS Gioielleria (
				Id VARCHAR(36) NOT NULL PRIMARY KEY,
				Tipologia INT NOT NULL,
				Nome VARCHAR(255) NOT NULL,
				Email VARCHAR(255) NOT NULL,
				Password VARCHAR(255) NOT NULL,
				QuotazioneOroNuovo DOUBLE NOT NULL,
				QuotazioneArgentoNuovo DOUBLE NOT NULL,
				ValutazioneOroVecchio DOUBLE NOT NULL,
				ValutazioneArgentoVecchio DOUBLE NOT NULL
			);

Creiamo degli utenti e delle gioiellerie di prova: 

			INSERT INTO cliente (Id, Tipologia, Nome, Cognome, Email, Password, TipoPreferito, MaterialePreferito) 
			VALUES (UUID(), '2', 'Maurici', 'Francesco', 'mauricivip@hotmail.it', 'francesco', '1', '2');
			INSERT INTO cliente (Id, Tipologia, Nome, Cognome, Email, Password, TipoPreferito, MaterialePreferito) 
			VALUES (UUID(), '2', 'Veronica', 'Chiantia', 'chiantiaveronica00@gmail.it', 'veronica', '2', '2');
			INSERT INTO cliente (Id, Tipologia, Nome, Cognome, Email, Password, TipoPreferito, MaterialePreferito) 
			VALUES (UUID(), '2', 'Sabrina', 'Rampanti', 'sabrinarampanti@gmail.com', 'sabrina', '3', '1');
			INSERT INTO cliente (Id, Tipologia, Nome, Cognome, Email, Password, TipoPreferito, MaterialePreferito) 
			VALUES (UUID(), '2', 'Gaetano', 'Maurici', 'mauricitano@hotmail.it', 'gaetano', '4', '1');

			INSERT INTO gioielleria (Id, Tipologia, Nome, Email, Password, QuotazioneOroNuovo, QuotazioneArgentoNuovo, ValutazioneOroVecchio, ValutazioneArgentoVecchio) 
			VALUES (UUID(), 1, 'Gioielleria Taibbi', 'gioielleriataibbi@gmail.com', 'gioielleria', 62.5, 12.4, 35.3, 10.2);
			INSERT INTO gioielleria (Id, Tipologia, Nome, Email, Password, QuotazioneOroNuovo, QuotazioneArgentoNuovo, ValutazioneOroVecchio, ValutazioneArgentoVecchio) 
			VALUES (UUID(), 1, 'Gioielleria Schifano', 'gioielleriaschifano@gmail.com', 'schifano', 50.6, 7.4, 29.3, 3.2);
			INSERT INTO gioielleria (Id, Tipologia, Nome, Email, Password, QuotazioneOroNuovo, QuotazioneArgentoNuovo, ValutazioneOroVecchio, ValutazioneArgentoVecchio) 
			VALUES (UUID(), 1, 'Gioielleria Bellia', 'gioielleriabellia@gmail.com', 'bellia', 55.6, 10.4, 33.3, 5.2);
			INSERT INTO gioielleria (Id, Tipologia, Nome, Email, Password, QuotazioneOroNuovo, QuotazioneArgentoNuovo, ValutazioneOroVecchio, ValutazioneArgentoVecchio) 
			VALUES (UUID(), 1, 'Gioielleria Cutaia', 'gioielleriacutaia@gmail.com', 'cutaia', 60.6, 11.4, 39.3, 8.2);

A questo punto il DB è pronto per essere utilizzato ....



--------------------------------------------------- C++ (modulo Server) -------------------------------------------------------------

Per l'avvio del server aprire tramite VisualStudio il file soluzione (JewelryBookAPL - Server.sln) che si trova al seguente path:
 --> C:\APLProject\ProgettoAPL\JewelryBookAPL - Server

N.B. Il file (main.cpp) che contiene il metodo main richiamato nel progetto si trova al seguente path: 
 --> C:\APLProject\ProgettoAPL\SocketServer\ServerSocketLib



--------------------------------------------------- C# (modulo Client) --------------------------------------------------------------

Per l'avvio del client aprire tramite VisualStudio il file soluzione (APL-ServerDef.sln) che si trova al seguente path:
 --> C:\APLProject\ProgettoAPL\APL-ServerDef



--------------------------------------------------- PYTHON (modulo Statistiche) -----------------------------------------------------

Per ispezionare il codice Python relativo alle statistiche esso si trova nel file test.py al seguente path:
 --> C:\APLProject\ProgettoAPL\APLStatistics


I passi seguenti vanno effettuati per visualizzare solo le statistiche attuali del programma (decommentare plot.Show() dal file test.py)

N.B. Per essere in linea con il funzionamento del programma bisogna almeno avere una versione di python 2.x o 3.x

Se si utilizza VSCode impostare un interprete (o generare un venv) python tramite lo shortcut Ctrl+Shift+P

A questo punto installare mysql-connector-python e matplotlib recandosi aprendo un nuovo terminale su VSCode
utilizzando la sintassi seguente (non dovrebbe essere necessario ma se non si riuscisse ad aprire il file):

C:\APLProject\ProgettoAPL\APLStatistics>pip install mysql-connector-python   e   C:\APLProject\ProgettoAPL\APLStatistics>pip install matplotlib

*Se l'esecuzione di test.py non va a buon fine commentare momentaneamente le ultime tre righe e decommentare plot.Show().



 



