const Sequelize = require("sequelize");
const sequelize = new Sequelize("sequelize_todo",
        'root',
        '123456',
        {host:'127.0.0.1',dialect:'mysql',operatorsAliases:false});

module.exports = sequelize;
global.sequelize = sequelize;