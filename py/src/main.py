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
data2 = pd.read_csv(r"G:\Documents\GitHub\Gaokao\Data\rank 2022.csv", encoding="gbk")

if __name__ == '__main__':
    #输入要求
    request = input();
    #根据分数获取排名
    rank = ""
    wish = ""
    if(request == "get_rank"):
        score = input()
        rank = process.get_rank(score, data1)
        print(rank)
    if(request == "input_wish"):
        wish = input()
        grade_in = rank
        cinn = wish.split()
    if(request == "generate"):
        for major in cinn:
            cinn = wish.split()
            rep = []
            eep = []
            for major in cinn:
                fl = pd.read_csv(f"D:\stuady\git\Gaokao\Data\sorts/{major}.csv")
                n = 0
                for i in fl["投档最低位次"]:
                    n = n + 1
                    if abs(i - grade_in) <= 1000:
                        date = fl.iloc[n:n + 1, 0:4]
                        rep.append(date.to_string(header=False))
            for i in rep:
                t = i.split()[1:]
                t[0] = t[0][2:]
                t[1] = t[1][4:]
                eep.append(t)
                eep.append(t)
        df = pd.DataFrame(eep, columns=["专业名称", "学校名称", "计划录取人数", "最低录取名次"])
        df.to_csv('site.csv')
        





#保险=101 财政=102 管理=103 会计=104 金融=105 经济=106 贸易=107 信管=108 营销=109
#大气=201 地理=202 地质=203 化学=204 力学=205 农学=206 生物=207 食品=208 数学=209 统计=210
#物理=211
#材料=301 城市规划=302 电气自动化=303 电子=304 风光园林=305 工业=306 光学=307 化工=308 机械=309
#计算机=310 建筑=311 软件=312 生物工程=313 石油=314 通讯=315 土木=316
#广告=401 汉语=402 教育=4.3 历史=404 社会=405 心理=406 新闻传媒=407 英语=408 哲学=409 政治=410
#护理=501 基础医学=502 口腔=503 临床=504 药学=505 预防公卫=506 中医=507

