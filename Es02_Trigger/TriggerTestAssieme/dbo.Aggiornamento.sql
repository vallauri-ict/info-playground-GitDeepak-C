CREATE TRIGGER Aggiornamento
	ON [dbo].[Driver]
	AFTER UPDATE
	AS
	BEGIN
		INSERT INTO StoricoAggiornamenti (
		[number],
		[data])
		(SELECT d.*, i.*, GETDATE() FROM deleted d, inserted i
		WHERE d.number=i.number)

		INSERT INTO StoricoAggiornamenti (
		[number],
		[full_name],
		[country],
		[date_birth],
		[team_id],
		[podiums_number],
		[numberNew],
		[full_nameNew],
		[countryNew],
		[date_birthNew],
		[team_idNew],
		[podiums_numberNew])
		(SELECT d.*, i.*, GETDATE() FROM deleted d, inserted i
		WHERE d.number=i.number)
	END