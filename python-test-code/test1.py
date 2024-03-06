# Does not give the correct answer

o = {"x": 0, "y": 0}
l = []
for i in range(6):
  m = o
  m["x"] = i
  m["y"] = i * 2
  l.append(m)
print(l)
