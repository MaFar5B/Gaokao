import pandas as pd
import seaborn as sns
import matplotlib.pyplot as plt
import warnings

warnings.filterwarnings('ignore')
plt.rcParams["font.sans-serif"]=["SimHei"]
plt.rcParams["axes.unicode_minus"]=False

data1 = pd.read_csv("G:\Documents\GitHub\Gaokao\Data\grade_line.csv")

def getRank(score):#获取学生的位次
    index = data1[data1["分数段"] == score].index[0]
    return data1["累计人数"][index]
    
