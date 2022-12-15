//testing modules

//path module
/* 
const path = require('path');

var pathObj = path.parse(__filename);
console.log(pathObj);
*/

const os = require('os');
var totalMem = os.totalmem();
var freeMem = os.freemem();

console.log('total memory: ' + totalMem);
console.log('free memory: ' + freeMem);

console.log(`total  mem: ${totalMem}`);
console.log(`free  mem: ${freeMem}`);