'''
Created on 2023年7月20日

@author: MaFar
'''
import process
import pandas as pd
import seaborn as sns
import matplotlib.pyplot as plt
import warnings

warnings.filterwarnings('ignore')
plt.rcParams["font.sans-serif"]=["SimHei"]
plt.rcParams["axes.unicode_minus"]=False
data1 = pd.read_csv(r"G:\Documents\GitHub\Gaokao\Data\grade_line.csv")
data2 = pd.read_csv(r"G:\Documents\GitHub\Gaokao\Data\rank .csv", encoding="gbk")

if __name__ == '__main__':
    score = input()
    rank = process.get_rank(score, data1)
    school_out = data2[(data2['rank'] > int(rank)) & (data2['rank'] < int(rank) + 100)]
    print(rank)
    pass