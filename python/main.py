import pass_validator
import re

id_re = re.compile(r"[A-Z]{2}-\d{8}")
rooms = ["Standard", "Standard+", "Pro", "President"]


def parse_res(res):
    import json

    # load data from jsonfile
    print("Validating data from file %s" % res)
    f = open(res, "r")
    res = json.loads(f.read())
    datetime = res[0]["order"]["start_date"]
    for usr in res:
        # foreigners must have passport
        if usr["address"]["country"] != "poland" and (
            not "passport" in usr
            or not usr["passport"]
            or len(usr["passport"]) != 12
            or not pass_validator.validate(usr["passport"])
        ):
            print("Passport info invalid")
            return False
        if usr["address"]["country"] == "poland" and (
            not "id_card" in usr
            or not usr["id_card"]
            or len(usr["id_card"]) != 11
            or not id_re.fullmatch(usr["id_card"])
        ):
            print("ID card info invalid")
            return False
        # import datetime
        if usr["order"]["start_date"] != datetime:
            print("Start date must be the same")
            return False
        # check if room names correct
        if usr["order"]["apartment_type"] not in rooms:
            print("Incorrect apartment type")
            return False
    return True


if __name__ == "__main__":
    import sys

    info = sys.argv[1]
    res = parse_res(info)
    if res:
        print("Reservation inof is ok")
        exit(0)
    else:
        print("Reservation inof is not ok")
        exit(1)
