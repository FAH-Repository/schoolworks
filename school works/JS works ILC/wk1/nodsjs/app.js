//want to encapsulate modules, private unless you need it public
/*
you want to work with one module
*/
const logger = require('./logger');//require loads
logger.log('message');

/* function load
const log = require('./logger');
log('message');
*/


/*
//console.log(module);
outputs
Module {
  id: '.',
  path: 'C:\\Users\\pseudomonger\\Desktop\\ILCWORKS\\nodsjs',
  exports: {},
  parent: null,
  filename: 'C:\\Users\\pseudomonger\\Desktop\\ILCWORKS\\nodsjs\\part2.js',
  loaded: false,
  children: [],
  paths: [
    'C:\\Users\\pseudomonger\\Desktop\\ILCWORKS\\nodsjs\\node_modules',
    'C:\\Users\\pseudomonger\\Desktop\\ILCWORKS\\node_modules',
    'C:\\Users\\pseudomonger\\Desktop\\node_modules',
    'C:\\Users\\pseudomonger\\node_modules',
    'C:\\Users\\node_modules',
    'C:\\node_modules'
  ]
}

each file is a module, notice its not loaded,
*/