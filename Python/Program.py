#input, read data
inp=input("write any thing ")

#output, pprint data
print("Hello {}".format(inp))

#data types
id = 7 
title ="Check valid login"
symbol='A'
peektime=36.34
defaultflag=True

print("id={},title={},symbol={},peektime={},defaultflag={}".format(id,title,symbol,peektime,defaultflag))

# Decision -if
if peektime > 10:
    print("peektime greater than 10")
    pass

# Decision -if else
if peektime < 10:
    print("peektime less than 10")
    pass
else:
    print("peektime not less than 10")

# Decision -if elif
if peektime >10:
    print("peektime greater than 10")
elif peektime ==10:
    print("peektime equal 10")
else:
    print("peektime less than 10")

# Decision -nested if
if peektime<10:
    print("peektime less than 10")
    if peektime < 5:
        print("peektime less than 5")


# Collections
Browsers = ["Chrome","FireFox","Edge"]
Browsers.append("Safari")
print(Browsers)
print(Browsers.pop(0))

Dictionary = {1:"Chrome",2:"FireFox",3:"Edge"}
print(Dictionary.get(1))
print(Dictionary.items())
print(Dictionary.keys())

# Loops
for target_list in Browsers:
    print(target_list)

for target_list2 in range(1,20):
    print(target_list2)

j=10
while j > 3:
    print(j)
    j = j -1