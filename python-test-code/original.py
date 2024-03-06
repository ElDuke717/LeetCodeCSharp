o = {"x": 0, "y": 0}
l = []
for i in xrange(0, 5):
  m = o
  m["x"] = i
  m["y"] = i * 2
  l.append(m)
print(l)