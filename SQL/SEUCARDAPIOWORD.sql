USE SeuCardapio_victor

GO

CREATE TABLE Entregas_sc (
IdEntregas_sc INT IDENTITY PRIMARY KEY,
IdPedidos_sc INT NOT NULL,
Forncedor_sc VARCHAR(30) NOT NULL,
CNPJforn_sc NUMERIC(20) NOT NULL,
Entregador_sc VARCHAR(50) NOT NULL,
ContatoEntregador CHAR(15) NOT NULL,
PreçoFretes_sc DECIMAL(4, 2) NOT NULL,
DiasdaSemana_sc VARCHAR(25) NOT NULL,
Realizados_sc VARCHAR(5) NOT NULL,
Suspensos_sc VARCHAR(5) NOT NULL,
FOREIGN KEY (IdPedidos_sc) REFERENCES Pedidos_sc(IdPedidos_sc),
);
