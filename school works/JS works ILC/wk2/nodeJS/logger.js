const EventEmitter = require('events');
//const emitter = new EventEmitter();

var url = 'https://mylogger.io/log';

class Logger extends EventEmitter{

    log(message){ //dont need function keyword when in a class, is just a method
        console.log(message);
        
        //raise an event
        this.emit('messageLogged', {id: 1, url: 'http://'});
        }


}

module.exports = Logger;
