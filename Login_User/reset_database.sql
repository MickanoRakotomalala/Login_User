-- Désactiver les contraintes de clés étrangères
EXEC sp_MSforeachtable @command1="ALTER TABLE ? NOCHECK CONSTRAINT ALL";

-- Réinitialiser les tables
EXEC sp_MSforeachtable @command1="DELETE FROM ?";

-- Réactiver les contraintes de clés étrangères
EXEC sp_MSforeachtable @command1="ALTER TABLE ? CHECK CONSTRAINT ALL";
