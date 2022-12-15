var url = 'http://mylogger.io/log'; 
function log(message){
//http request to this url (fake)
console.log(message);
}

module.exports.log = log;//empty object

//module.exports = log;// a function export



//module.exports.url = url;
// module.exports.endPoint = url;  can export as endpoint, 
//want to export few so most things are under the hood