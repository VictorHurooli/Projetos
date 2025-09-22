use SeuCardapio_victor

GO

CREATE TRIGGER TR_AtualizaEntregas_sc
ON Pedidos_sc
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE Entregas_sc
    SET Entregador_sc = i.Entregador_sc
    FROM Entregas_sc e
    INNER JOIN inserted i ON e.IdEntregas_sc = i.IdPedidos_sc
    WHERE i.Entregador_sc IS NOT NULL; 
END;

go