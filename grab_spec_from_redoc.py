### grabs redoc openapi spec from redoc url

import requests
import json


# grab 
# const __redoc_state =
def grab_spec_from_redoc(url = "https://myanimelist.net/apiconfig/references/api/v2"):
    r = requests.get(url)
    spec = r.text
    # iterate line by line
    for line in spec.splitlines():
        if "__redoc_state" in line:
            # grab the json
            raw_spec = line.split("= ")[1]
            # remove trailing ;
            raw_spec = raw_spec[:-1]
            break
    # parse json
    redoc_spec = json.loads(raw_spec)
    # go to data.openapi
    openapi_spec = redoc_spec["spec"]["data"]
    # write to file
    with open("spec.json", "w") as f:
        json.dump(openapi_spec, f)

if __name__ == "__main__":
    grab_spec_from_redoc()
