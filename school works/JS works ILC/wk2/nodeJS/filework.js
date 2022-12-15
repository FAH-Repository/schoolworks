const fs = require('fs');

//const files = fs.readdirSync('./');
//console.log(files);

//error test
fs.readdir('$', function(err, files) {//needs callback function, all non sync need one
if(err) console.log('Error', err);
else console.log('Result',  files);
});
/*  //fixed
fs.readdir('./', function(err, files) {//needs callback function, all non sync need one
if(err) console.log('Error', err);
else console.log('Result',  files);

});
*/