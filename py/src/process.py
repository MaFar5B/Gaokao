import pandas as pd
import seaborn as sns
import matplotlib.pyplot as plt
import warnings

warnings.filterwarnings('ignore')
plt.rcParams["font.sans-serif"]=["SimHei"]
plt.rcParams["axes.unicode_minus"]=False

#获取学生的位次
def getRank(score, data):
    return data.loc[data['grade'] == score, 'rank'].values[0]

#排名靠近专业及院校
n = 0
def advise(rank, data):
    global n
    for i in data['投档最低位次']:
        n = n + 1
        if int(i) >= rank :
            break
    if n < 48:
        print(data.iloc[0:97,2:5])
    if n > 18190:
        print(data.iloc[18190:18287, 2:5])
    else:
        print(data.iloc[n-48:n+48,2:5])
        
