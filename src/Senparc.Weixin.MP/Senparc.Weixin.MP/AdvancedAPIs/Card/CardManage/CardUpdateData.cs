﻿/*----------------------------------------------------------------
    Copyright (C) 2016 Senparc
    
    文件名：CardUpdateData.cs
    文件功能描述：卡券更新需要的数据
    
    
    创建标识：Senparc - 20150211
    
    修改标识：Senparc - 20150303
    修改描述：整理接口
 
    修改标识：Senparc - 20160808
    修改描述：修改Card_MemberCardUpdateData
----------------------------------------------------------------*/

using Senparc.Weixin.Helpers;

namespace Senparc.Weixin.MP.AdvancedAPIs.Card
{
    /// <summary>
    /// 会员卡数据
    /// </summary>
    public class Card_MemberCardUpdateData : BaseUpdateInfo
    {
        /// <summary>
        /// 积分清零规则
        /// 非必填
        /// </summary>
        public string bonus_cleared { get; set; }
        /// <summary>
        /// 积分规则
        /// 非必填
        /// </summary>
        public string bonus_rules { get; set; }
        /// <summary>
        /// 储值说明
        /// 非必填
        /// </summary>
        public string balance_rules { get; set; }
        /// <summary>
        /// 特权说明
        /// 非必填
        /// </summary>
        public string prerogative { get; set; }
        /// <summary>
        /// 设置为true时用户领取会员卡后系统自动将其激活，无需调用激活接口。
        /// 非必填
        /// </summary>
        [JsonSetting.IgnoreValueAttribute(false)]
        public bool auto_activate { get; set; }
        /// <summary>
        /// 设置为true时会员卡支持一键激活，不允许同时传入activate_url字段，否则设置wx_activate失效。
        /// 非必填
        /// </summary>
        [JsonSetting.IgnoreValueAttribute(false)]
        public bool wx_activate { get; set; }

        /// <summary>
        /// 激活会员卡的url，与“bind_old_card_url”字段二选一必填。
        /// </summary>
        public string activate_url { get; set; }
        /// <summary>
        /// 设置跳转外链查看积分详情。仅适用于积分无法通过激活接口同步的情况下使用该字段。
        /// 非必填
        /// </summary>
        public string bonus_url { get; set; }
        /// <summary>
        /// 初始设置积分 int型数据
        /// 非必填,null时显示查看
        /// </summary>
        [JsonSetting.IgnoreValueAttribute(0)]
        public int init_increase_bonus { get; set; }

        /// <summary>
        /// 设置跳转外链查看余额详情。仅适用于余额无法通过激活接口同步的情况下使用该字段。
        /// 非必填
        /// </summary>
        public string balance_url { get; set; }
        /// <summary>
        /// 自定义会员信息类目，会员卡激活后显示。
        /// 非必填
        /// </summary>
        public CustomField custom_field1 { get; set; }
        /// <summary>
        /// 自定义会员信息类目，会员卡激活后显示。
        /// 非必填
        /// </summary>
        public CustomField custom_field2 { get; set; }
        /// <summary>
        /// 自定义会员信息类目，会员卡激活后显示。
        /// 非必填
        /// </summary>
        public CustomField custom_field3 { get; set; }
        /// <summary>
        /// 自定义会员信息类目，会员卡激活后显示
        /// 非必填
        /// </summary>
        public CustomCell custom_cell1 { get; set; }

        /// <summary>
        /// 卡背景图，非必填
        /// </summary>
        public string background_pic_url { get; set; }
    }

    /// <summary>
    /// 门票数据
    /// </summary>
    public class Card_ScenicTicketUpdateData : BaseUpdateInfo
    {
        /// <summary>
        /// 导览图url
        /// 非必填
        /// </summary>
        public string guide_url { get; set; }
    }

    /// <summary>
    /// 电影票数据
    /// </summary>
    public class Card_MovieTicketUpdateData : BaseUpdateInfo
    {
        /// <summary>
        /// 电影票详请
        /// 非必填
        /// </summary>
        public string detail { get; set; }
    }

    /// <summary>
    /// 飞机票数据
    /// </summary>
    public class Card_BoardingPassUpdateData : BaseUpdateInfo
    {
        /// <summary>
        /// 起飞时间，上限为17 个汉字
        /// 非必填
        /// </summary>
        public string departure_time { get; set; }
        /// <summary>
        /// 降落时间，上限为17 个汉字
        /// 非必填
        /// </summary>
        public string landing_time { get; set; }
        /// <summary>
        /// 登机口。如发生登机口变更，建议商家实时调用该接口变更
        /// </summary>
        public string gate { get; set; }
        /// <summary>
        /// 登机时间，只显示“时分”不显示日期，按时间戳格式填写。如发生登机时间变更，建议商家实时调用该接口变更
        /// </summary>
        public string boarding_time { get; set; }
    }
}
