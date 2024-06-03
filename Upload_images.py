import os
import pyodbc

# Configura tu conexión a SQL Server utilizando la autenticación de Windows
conn = pyodbc.connect(
    'DRIVER={ODBC Driver 17 for SQL Server};'
    'SERVER=DESKTOP-MIJH44D\\SQLSADAN;'
    'DATABASE=KineApp;'
    'Trusted_Connection=yes;'
)

cursor = conn.cursor()

# Asegúrate de que la tabla exista
create_table_query = """
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Musculo' AND xtype='U')
CREATE TABLE Musculo (
    Id_Musculo INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(50) NOT NULL,
    Punto VARBINARY(MAX),
    Id_Parte INT NULL
)
"""
cursor.execute(create_table_query)
conn.commit()

# Carpeta que contiene las imágenes
image_folder = 'C:/Users/adanv/OneDrive/Escritorio/Programacion/Lenguajes/c#/KineMovil/images'

# Lee todas las imágenes en la carpeta y las inserta en la base de datos
for filename in os.listdir(image_folder):
    if filename.endswith('.jpg') or filename.endswith('.png'):
        # Ruta completa de la imagen
        file_path = os.path.join(image_folder, filename)
        
        # Lee el contenido de la imagen
        with open(file_path, 'rb') as file:
            img_data = file.read()
        
        # Nombre del músculo (sin extensión de archivo)
        muscle_name = os.path.splitext(filename)[0]
        
        # Inserta los datos en la base de datos
        insert_query = """
        INSERT INTO Musculo (Nombre, Punto, Id_Parte)
        VALUES (?, ?, ?)
        """
        # Supongamos que IdParte es 1 por defecto o puede ser ajustado según sea necesario
        cursor.execute(insert_query, (muscle_name, img_data, 1))

# Confirma los cambios y cierra la conexión
conn.commit()
cursor.close()
conn.close()
