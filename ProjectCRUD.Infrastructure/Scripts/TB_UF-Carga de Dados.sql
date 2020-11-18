USE ProgramacaoWeb;

INSERT INTO TB_UF (uf_sigla, uf_nome, uf_dt_cadastro, uf_deletado)
VALUES  ('AC', 'Acre', GETDATE(), 0),
		('AL', 'Alagoas', GETDATE(), 0),
		('AP', 'Amap�', GETDATE(), 0),
		('AM', 'Amazonas', GETDATE(), 0),
		('BA', 'Bahia', GETDATE(), 0),
		('CE', 'Cear�', GETDATE(), 0),
		('DF', 'Distrito Federal', GETDATE(), 0),
		('ES', 'Esp�rito Santo', GETDATE(), 0),
		('GO', 'Goi�nia', GETDATE(), 0),
		('MA', 'Maranh�o', GETDATE(), 0),
		('MT', 'Mato Grosso', GETDATE(), 0),
		('MS', 'Mato Grosso do Sul', GETDATE(), 0),
		('MG', 'Minas Gerais', GETDATE(), 0),
		('PA', 'Par�', GETDATE(), 0),
		('PB', 'Para�ba', GETDATE(), 0),
		('PR', 'Paran�', GETDATE(), 0),
		('PE', 'Pernambuco', GETDATE(), 0),
		('PI', 'Piau�', GETDATE(), 0),
		('RJ', 'Rio de Janeiro', GETDATE(), 0),
		('RN', 'Rio Grande do Norte', GETDATE(), 0),
		('RS', 'Rio Grande do Sul', GETDATE(), 0),
		('RO', 'Rond�nia', GETDATE(), 0),
		('RR', 'Roraima', GETDATE(), 0),
		('SC', 'Santa Catarina', GETDATE(), 0),
		('SP', 'S�o Paulo', GETDATE(), 0),
		('SE', 'Sergipe', GETDATE(), 0),
		('TO', 'Tocantins', GETDATE(), 0);

SELECT * FROM TB_UF;