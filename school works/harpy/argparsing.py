import argparse

parser = argparse.ArgumentParser(description="repeats another one")# just parses sys argv for ease of use and less programming work to defin sys args
parser.add_argument("-n", default=1,help="number of times to repeat", type=int)# -n used conventionaly for the number or iterations,-h is used for help, type checks input, default sets default n
args = parser.parse_args()


for _ in range(args.n):#dont have to set args.n to int as the argument is type=int
    print("another one")
