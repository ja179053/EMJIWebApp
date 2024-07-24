
CREATE PROCEDURE sp_SelectReservationsToday
@Date datetime
AS
SELECT * FROM Reservations WHERE [Date] = @Date