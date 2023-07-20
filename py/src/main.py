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

if __name__ == '__main__':
    score = input()
    print(data1.head)
    pass