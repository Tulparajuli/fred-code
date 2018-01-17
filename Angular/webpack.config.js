var path = require('path');

module.exports = {
  entry: './dist/swapi.js',
  output: {
    path: path.resolve(__dirname, 'public'),
    filename: 'app.bundle.js'
  }
};
