export const meetupDay = (year, month, day, week) =>  {
  var maxDay = getMaxDay(year, month+1);
  var dayName = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday']
  var dayCount = dayName.indexOf(day)
  if (!isNaN(week[0])){
      week = parseInt(week[0])
      var count = 1
      for (var i = 1; i <= maxDay;i++){
          if (new Date(year,month,i).getDay() == dayCount){
              if (count == week){
                  return new Date(year,month,i);
              }
              else{
                  count++;
              }
          }
      }
      throw new Error();
  }
  else if (week == 'last'){
       for (var i = maxDay; i >= 1; i--){
          if (new Date(year,month,i).getDay() == dayCount){
              return new Date(year,month,i);
          }
       }
  }
  else if (week == 'teenth'){
      for (var i = 13; i <= 19; i++){
          if  (new Date(year,month,i).getDay() == dayCount){
              return new Date(year,month,i)
          }
      }
  }

}



function getMaxDay(year, month) {
  switch(month){
      case 1:
      case 3:
      case 5:
      case 7:
      case 8:
      case 10:
      case 12:
          return 31;
      case 4:
      case 6:
      case 9:
      case 11:
          return 30;
      case 2:
          if (year % 400 == 0){
              return 29;
          }
          else if (year % 100 == 0){
              return 28;
          }
          else if (year % 4 == 0){
              return 29;
          }
          else {
              return 28;
          }
  }
}