use ProgramacaoWeb;

INSERT INTO TB_MUNICIPIO (mnp_codigo_ibge, mnp_dt_cadastro, mnp_deletado)
VALUES	(3550308, 'S�o Paulo',          GETDATE(), 0),
		(3518800, 'Guarulhos',          GETDATE(), 0),
		(3526803, 'Len��is Paulista',   GETDATE(), 0),
		(3301702, 'Duque de Caxias',    GETDATE(), 0),
		(3303302, 'Niter�i',            GETDATE(), 0);

SELECT * FROM TB_MUNICIPIO;