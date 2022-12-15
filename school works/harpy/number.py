def main():
    x = get_int("what is your phone number? ")
    print(f"thanks, we have recorded the value: {x}")

def get_int(prompt):
    while True:
        try:
            return int(input(prompt))
        except ValueError:
            pass
main()