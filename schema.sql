-- Create the database if it doesn't exist
CREATE DATABASE IF NOT EXISTS minigamehub_db;

-- Use the created database
USE minigamehub_db;

-- Create the users table
CREATE TABLE IF NOT EXISTS users (
    id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(255) NOT NULL UNIQUE,
    password_hash VARCHAR(255) NOT NULL
);
