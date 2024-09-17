from email.mime import image
import mysql.connector
import functools
import matplotlib.pyplot as plot
import os

# Si utilizza mysql-connector per effettuare la connessione al DB

mydb = mysql.connector.connect(
    host="localhost",
    database="jewelryapp",
    user="root",
    password="francesco",
)

# Dichiarazione di alcune funzioni comuni create per evitare ridondanza e favorire riuso del codice

def get_preferenze(response, numeroClienti, preferenza):
    for row in response:
        #  functools è una funzione per il casting che mi permette la 
        #  conversione da tupla a intero (numero totale di clienti)
        riga = functools.reduce(lambda sub, ele: sub * 10 + ele, row)
        division = riga / numeroClienti
        index = response.index(row)
        preferenza.insert(index, division * 100)
    return preferenza

def execute_query(query, type):
    typeQuery = mydb.cursor()
    typeQuery.execute(query)
    #utilizzo dell'operatore ternario di python
    response = typeQuery.fetchall() if type == 2 else functools.reduce(lambda sub, ele: sub * 10 + ele, typeQuery.fetchall()[0])
    return response

def set_plot(valori, chiavi, explosion, color, title):
    plot.pie(valori, labels = chiavi, explode = explosion, startangle=60, colors = color, autopct='%1.1f%%', textprops={'size': 'smaller'}, radius=0.6)
    plot.title(title)

# Definizione delle query che verranno effettuate sul DB
query1 = "select count(*) from cliente"
query2 = "select count(*) from cliente group by materialepreferito"
query3 = "select count(*) from cliente group by tipopreferito"

# Calcolo numero totale di occorrenze nella tabella "clienti"
countClienti = execute_query(query1, 1)    

# Richiamo funzione per ottenere le statistiche sul materiale preferito
preferenzeMateriale = []
preferenzeMateriale = get_preferenze(execute_query(query2, 2), countClienti, preferenzeMateriale) # ----- Richiamo funzione per ottenere le statistiche sui materiali preferiti 
chiaveMateriale = ["Argento", "Oro"]
valoreMateriale = [preferenzeMateriale[0], preferenzeMateriale[1]]
myExplode1 = [0.005,0.005]
myColor1 = ["#d6d6c2", "#e6ac00"]

# NotaBene: SI POTREBBE UTILIZZARE IL DICTIONARY (COME SOTTO) MA CIO' RIDUCE LA LEGGIBILITA' DEL CODICE

# chiaveMateriale = []
# valoreMateriale = []
# dictMateriale = {
#     "Argento": preferenzeMateriale[0],
#     "Oro": preferenzeMateriale[1]
# }
# for key in dictMateriale.keys():
#     chiaveMateriale.append(key)
#     valoreMateriale.append(dictMateriale[key])

# Richiamo funzione per ottenere le statistiche sulle categorie preferite
preferenzaTipo = []
preferenzaTipo = get_preferenze(execute_query(query3, 2), countClienti, preferenzaTipo)
chiaveTipo = ["Anelli", "Bracciali", "Collane", "Orecchini"]
valoreTipo = [preferenzaTipo[0], preferenzaTipo[1], preferenzaTipo[2], preferenzaTipo[3]]
myExplode2 = [0.005,0.005,0.005,0.005]
myColor2 = ["#ffe680", "#ff9980", "#99c2ff","#ccffcc"]

# Si usano i subplot() in modo tale da affiancare e mostrare plot differenti nella stessa finestra 
#Il plot seguente è relativo alle preferenze di materiale 
plot.subplot(1,2,1)
set_plot(valoreMateriale, chiaveMateriale, myExplode1, myColor1, "Preferenze di materiale")
#Il plot seguente è relativo alle preferenze di categoria
plot.subplot(1,2,2)
set_plot(valoreTipo, chiaveTipo, myExplode2, myColor2, "Preferenze di prodotto")

# plot.show()

#Si effettua il salvataggio di un'immagine contenente il plot generato
imagePath = "C:/APLProject/ProgettoAPL/APL-ServerDef/Plot"
isExists = os.path.exists(imagePath)
plot.savefig(imagePath)


