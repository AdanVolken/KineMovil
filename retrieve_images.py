import os
import pyodbc

# Configura tu conexión a SQL Server
conn = pyodbc.connect(
    'DRIVER={ODBC Driver 17 for SQL Server};'
    'SERVER=DESKTOP-MIJH44D\\SQLSADAN;'
    'DATABASE=KineApp;'
    'Trusted_Connection=yes;'
)

cursor = conn.cursor()

# Consulta para recuperar los datos de la tabla Musculo
select_query = "SELECT Id_Musculo, Nombre, Punto FROM Musculo"

cursor.execute(select_query)

# Carpeta donde se guardarán las imágenes recuperadas
output_folder = 'C:/Users/adanv/OneDrive/Escritorio/Programacion/Lenguajes/c#/KineMovil/retrieved_images'

# Crea la carpeta si no existe
if not os.path.exists(output_folder):
    os.makedirs(output_folder)

# Recupera los datos y guarda las imágenes
for row in cursor:
    muscle_id, muscle_name, img_data = row
    # Define el nombre del archivo
    output_path = os.path.join(output_folder, f"{muscle_name}.jpg")
    # Guarda la imagen
    with open(output_path, 'wb') as file:
        file.write(img_data)
    print(f"Imagen guardada como: {output_path}")

# Cierra la conexión
cursor.close()
conn.close()
