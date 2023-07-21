'''
Created on 2023年7月20日

@author: MaFar
'''
import process
import pandas as pd
import seaborn as sns
import matplotlib.pyplot as plt
import warnings
import os
import numpy as np

file_path = os.path.realpath(__file__)
py_path = os.path.dirname(os.path.abspath(file_path))
Gaokao_path = os.path.dirname(os.path.dirname(py_path))
warnings.filterwarnings('ignore')
plt.rcParams["font.sans-serif"]=["SimHei"]
plt.rcParams["axes.unicode_minus"]=False
data1 = pd.read_csv(f"{Gaokao_path}\Data/grade_line.csv")

if __name__ == '__main__':
    #输入要求
    request = input()
    #根据分数获取排名
    if(request == "get_rank"):
        score = input()
        rank = process.get_rank(score, data1)
        print(rank)
    if(request == "generate"):
        rank = int(input())
        wish = input()
        cinn = wish.split()
        kong = pd.DataFrame()
        kong.to_csv(f"{Gaokao_path}\Data/result.csv")
        headers = [["专业名称"],["学校名称"],["计划录取人数"],["最低录取名次"]]
        for major in cinn:
            fl = pd.read_csv(f"{Gaokao_path}\Data\sorts/{major}.csv")

            # rank1 = max(0,rank - 3000)
            # rank2 = min(rank + 3000,len(fl['投档最低位次']))
            index1 = np.searchsorted(fl['投档最低位次'],rank - 3000,side='left')
            index2 = np.searchsorted(fl['投档最低位次'],rank + 3000,side='left')
            # start_index = max(0,index - 7)
            # end_index = min(index + 13 , len(fl['投档最低位次']))
            nearest_rows = fl.iloc[index1:index2]
            nearest_rows.to_csv(f"{Gaokao_path}\Data/result.csv",mode='a',header=False,index=False)

            # index = np.searchsorted(fl['投档最低位次'],rank,side='left')
            # start_index = max(0,index - 7)
            # end_index = min(index + 13 , len(fl['投档最低位次']))
            nearest_rows = fl.iloc[index1:index2]
            nearest_rows.to_csv(f"{Gaokao_path}\Data/result.csv",mode='a')




