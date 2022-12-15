import requests, sys, json

try:
    # if (sys.argv) != 2:
    #    sys.exit()

    response = requests.get("https://api.coindesk.com/v1/bpi/currentprice.json")
    o = response.json()
    # print(json.dumps(response.json(), indent = 2))

    hold = o["bpi"]["USD"]["rate"]
    total = sys.argv[1]
    total = float(total)
    print(hold)
except ValueError:
    sys.exit("value error")

except requests.RequestException:
    sys.exit()
