SELECT * FROM Usuarios


SELECT * FROM LlamadosProspectos

SELECT P.Nombre, P.TelefonoPrincipal, A.FechaAgenda, A.HoraAgenda, A.ObsProspecto
FROM Prospectos P
INNER JOIN Agendados A ON P.IdProspecto = A.IdProspecto;


INSERT INTO Prospectos (TelefonoPrincipal,Apellido,Nombre,LLamado,Venta) 
VALUES
(1122009988, 'Gutiérrez', 'Ariel',0, 0),
    (2233118877, 'Ferrer', 'Valeria', 0, 0),
    (3344227766, 'Ríos', 'Diego', 0, 0),
    (4455336655, 'Vega', 'Micaela', 0, 0),
    (5566441546, 'Santos', 'Lucas',0, 0),
    (6677554433, 'Alonso', 'Camila', 0, 0),
    (7788663322, 'Blanco', 'Francisco',0, 0),
    (8899772211, 'Godoy', 'Martina', 0, 0),
    (9900881100, 'Maldonado', 'Lucía',0, 0),
    (6677889933, 'Peralta', 'Facundo', 0, 0),
    (5544669900, 'Coronel', 'Abril', 0, 0),
    (1122009988, 'Villalba', 'Leonardo', 0, 0),
    (2233118877, 'Carmona', 'Renata', 0, 0),
    (3344227766, 'Soria', 'Lautaro', 0, 0),
    (4455336655, 'Ponce', 'Delfina', 0, 0),
    (5566445544, 'Valdez', 'Tomás', 0, 0),
    (6677554433, 'Bravo', 'Isabella', 1, 0),
    (7788663322, 'Ibarra', 'Nicolás', 0, 0),
    (8899772211, 'Ledesma', 'Julieta', 0, 0),
    (9900881100, 'Ortega', 'Ignacio', 0, 0);

     SELECT P.Nombre, P.Apellido, P.TelefonoPrincipal, LP.CodRespuesta, LP.Fecha, LP.Observacion
                                     FROM Prospectos P
                                     INNER JOIN LlamadosProspectos LP ON P.IdProspecto = LP.IdProspecto;
SELECT CodRespuesta, SUM(1) AS TotalLlamadas
FROM LlamadosProspectos
GROUP BY CodRespuesta
    
    
    SELECT * FROM Ventas
