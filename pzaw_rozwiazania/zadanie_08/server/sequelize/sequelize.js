const { Sequelize, DataTypes } = require('sequelize');

const sequelize = new Sequelize('zadanie08', 'root', '', {
    host: 'localhost',
    dialect: 'mariadb'
});

const Users = sequelize.define('Users', {
    username: {
      type: DataTypes.STRING,
      allowNull: false
    },
    password: {
        type: DataTypes.STRING,
        allowNull: false
      },
    role: {
      type: DataTypes.INTEGER,
      allowNull: false
    }
  }, {});
Users.sync();

const Articles = sequelize.define('Articles', {
    author: {
      type: DataTypes.STRING,
      allowNull: false
    },
    content: {
        type: DataTypes.STRING,
        allowNull: false
      }
  }, {});
const Comments = sequelize.define('Comments', {
    commentor: {
        type: DataTypes.STRING,
        allowNull: false
    },
    content: {
        type: DataTypes.STRING,
        allowNull: false
    }
})
Articles.Comments = Articles.hasMany(Comments);
Articles.sync();
Comments.sync();

module.exports = {
  Users,
  Articles,
  Comments
}