import pandas as pd
import seaborn as sns
import matplotlib.pyplot as plt
import warnings

warnings.filterwarnings('ignore')
plt.rcParams["font.sans-serif"]=["SimHei"]
plt.rcParams["axes.unicode_minus"]=False

data1 = pd.read_csv(r"D:\stuady\rankk.csv")

def getRank(score):#获取学生的位次
    index = data1[data1["分数段"] == score].index[0]
    return data1["累计人数"][index]

#排名靠近专业及院校
n = 0
def advise(rank):
    global n
    for i in data1['投档最低位次']:
        n = n + 1
        if int(i) >= rank :
            break
    if n < 48:
        print(data1.iloc[0:97,2:5])
    if n > 18190:
        print(data1.iloc[18190:18287, 2:5])
    else:
        print(data1.iloc[n-48:n+48,2:5])
