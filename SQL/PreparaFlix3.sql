USE [PreparaFlix_Victor]
GO

ALTER TABLE Assinaturas_Victor
ALTER COLUMN valorBruto_Assinatura DECIMAL(4,2);

GO

ALTER TABLE Assinaturas_Victor
ALTER COLUMN valorDesconto_duracaoAssinatura DECIMAL(4,2);

GO