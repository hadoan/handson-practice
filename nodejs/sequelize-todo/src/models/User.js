const Sequelize = require('sequelize')

module.exports = sequelize.define('users', {
    id: {
        type: Sequelize.INTEGER(11),
        allowNull:false,
        autoIncrement: true,
        primaryKey: true
    },
    username: {
        type: Sequelize.STRING(30),
        allowNull: false,
        unique: true
    },
    password: {
        type: Sequelize.STRING(25),
        allowNull: false
    }
})