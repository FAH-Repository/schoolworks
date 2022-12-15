from datetime import date, datetime

def main():
    get_time()

def get_time():
    inp = input("What is your birth date?")
    birth_year, birth_month, birth_day = inp.split("-")
    birth_year, birth_month, birth_day =  int(birth_year), int(birth_month), int(birth_day)
    birthday = datetime(birth_year, birth_month, birth_day, 0, 0)
    diff = datetime.now()- birthday
    time = (diff.total_seconds() / 60)
    print(time)



if __name__ == "__main__":
    main()