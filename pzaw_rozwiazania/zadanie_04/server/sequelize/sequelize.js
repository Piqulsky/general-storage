const { Sequelize, DataTypes } = require('sequelize');

const sequelize = new Sequelize('zadanie04', 'root', '', {
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
  }, {
});
Users.sync();

const Articles = sequelize.define('Articles', {
    author: {
      type: DataTypes.STRING,
      allowNull: false
    },
    content: {
        type: DataTypes.STRING,
        allowNull: false
      },
      score: {
      type: DataTypes.INTEGER,
      allowNull: false
    }
  }, {
});
const Comment = sequelize.define('Article', {
    commentor: {
        type: DataTypes.STRING,
        allowNull: false
    },
    content: {
        type: DataTypes.STRING,
        allowNull: false
    }
})
Articles.Comments = Articles.hasMany(Comment);
Articles.sync();

module.exports = {
  Users,
  Articles
}