CREATE DATABASE IF NOT EXISTS minigamehub_db;

USE minigamehub_db;

CREATE TABLE IF NOT EXISTS users (
    id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(255) NOT NULL UNIQUE,
    email varchar(255) NOT NULL UNIQUE,
    password_hash VARCHAR(255) NOT NULL
);
