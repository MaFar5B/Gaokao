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
<<<<<<< HEAD
        print(data1.iloc[n-48:n+48,2:5])

###读入分数获取学校（一刀切简单衔接版）
import pandas as pd

def get_rank_out(grade_in):
    all_rank = pd.read_csv(r"D:\2023.Gaokao\Data\grade_line.csv", encoding='gbk')
    rank_out = all_rank[all_rank['grade'] == int(grade_in)]
    return rank_out['rank'].astype(str).iloc[0]

grade_in = 599
rank_in = get_rank_out(grade_in)

all_school=pd.read_csv(r"D:\2023.Gaokao\Data\rank .csv", encoding='gbk')
school_out = all_school[(all_school['rank'] > int(rank_in)) & (all_school['rank'] < int(rank_in) + 100)]

print(school_out.head())

 
=======
        print(data.iloc[n-48:n+48,2:5])
        
>>>>>>> e6daa1cac7cb69b55b484e6554d6db65fba7f9e7
