﻿using System.Collections.Generic;
using Newtonsoft.Json;
using SiteServer.CMS.Core;
using SiteServer.CMS.Model;

namespace SiteServer.Cli.Updater.Model50
{
    public partial class TableTemplateMatch
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("nodeID")]
        public long NodeId { get; set; }

        [JsonProperty("publishmentSystemID")]
        public long PublishmentSystemId { get; set; }

        [JsonProperty("channelTemplateID")]
        public long ChannelTemplateId { get; set; }

        [JsonProperty("contentTemplateID")]
        public long ContentTemplateId { get; set; }

        [JsonProperty("filePath")]
        public string FilePath { get; set; }

        [JsonProperty("channelFilePathRule")]
        public string ChannelFilePathRule { get; set; }

        [JsonProperty("contentFilePathRule")]
        public string ContentFilePathRule { get; set; }
    }

    public partial class TableTemplateMatch
    {
        public const string OldTableName = "siteserver_TemplateMatch";

        public static readonly string NewTableName = DataProvider.TemplateMatchDao.TableName;

        public static readonly List<TableColumnInfo> NewColumns = DataProvider.TemplateMatchDao.TableColumns;

        public static readonly Dictionary<string, string> ConvertDict =
            new Dictionary<string, string>
            {
                {nameof(TemplateMatchInfo.ChannelId), nameof(NodeId)},
                {nameof(TemplateMatchInfo.SiteId), nameof(PublishmentSystemId)}
            };
    }
}
