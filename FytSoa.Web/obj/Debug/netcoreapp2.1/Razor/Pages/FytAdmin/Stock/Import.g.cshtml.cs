#pragma checksum "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Import.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "038223c839d0650732c42ed3a93415040513bc1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Stock.Pages_FytAdmin_Stock_Import), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Stock/Import.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Stock/Import.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Stock.Pages_FytAdmin_Stock_Import), null)]
namespace FytSoa.Web.Pages.FytAdmin.Stock
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"038223c839d0650732c42ed3a93415040513bc1f", @"/Pages/FytAdmin/Stock/Import.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Stock_Import : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Import.cshtml"
  
    ViewData["Title"] = "入库管理";
    Layout = AdminLayout.Pjax(HttpContext);

#line default
#line hidden
            BeginContext(144, 429, true);
            WriteLiteral(@"<div id=""container"">
    <style>
        .layui-col-220{width:400px;}
        .right-col-body{left:400px;}    
    </style>
    <div class=""layui-col-220"" id=""app"">
        <div class=""layui-nav-title"">入库单　　　<button class=""layui-btn layui-btn-sm"" id=""addIn""><i class=""layui-icon""></i>新增入库单</button></div>
        <ul class=""fyt-utree"">
            <li v-for=""it in list"" v-cloak :class=""{active: activeName == it.guid}"" ");
            EndContext();
            BeginContext(574, 73, true);
            WriteLiteral("@click=\"selected(it.guid)\">\r\n                <a class=\"layui-elip title\" ");
            EndContext();
            BeginContext(648, 188, true);
            WriteLiteral("@click=\"getList(it)\">{{it.packName}}</a>\r\n                <a class=\"layui-elip sums\"><span class=\"layui-badge layui-bg-blue\">{{it.goodsSum}}</span></a>\r\n                <span class=\"tool\" ");
            EndContext();
            BeginContext(837, 193, true);
            WriteLiteral("@click=\"tools(it,$event)\"><i class=\"layui-icon layui-icon-more\"></i></span>\r\n            </li>\r\n        </ul>\r\n        <dl class=\"layui-nav-child fyt-task-menu layui-hide\">\r\n            <dd><a ");
            EndContext();
            BeginContext(1031, 48, true);
            WriteLiteral("@click=\"edit()\">修改</a></dd>\r\n            <dd><a ");
            EndContext();
            BeginContext(1080, 467, true);
            WriteLiteral(@"@click=""deletes()"">删除</a></dd>
        </dl>
    </div>
    <div class=""right-col-body"">
        <div class=""list-wall"">
            <div class=""layui-form list-search"">
                <div class=""layui-inline"">
                    <input class=""layui-input"" id=""key"" autocomplete=""off"" placeholder=""请输入关键字查询"">
                </div>
                <div class=""layui-inline"">
                    <select id=""shops"" lay-search="""">
                        ");
            EndContext();
            BeginContext(1547, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa6cb1d73bde447d88b0036b6df3553e", async() => {
                BeginContext(1564, 11, true);
                WriteLiteral("--可根据店铺搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1584, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 35 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Import.cshtml"
                          
                            foreach (var item in Model.shopList)
                            {

#line default
#line hidden
            BeginContext(1711, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1743, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "822e6d076d4d40f3b46439bae48f2738", async() => {
                BeginContext(1771, 13, false);
#line 38 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Import.cshtml"
                                                      Write(item.ShopName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 38 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Import.cshtml"
                                   WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1793, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 39 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Import.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(1853, 387, true);
            WriteLiteral(@"                    </select>
                </div>
                <div class=""layui-inline lay-time-icon"">
                    <input class=""layui-input"" id=""times"" autocomplete=""off"" placeholder=""时间区间""><i class=""layui-icon layui-icon-date""></i>
                </div>
                <div class=""layui-inline"">
                    <select id=""branks"">
                        ");
            EndContext();
            BeginContext(2240, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "340658b107334fbfaa70d4d7dba0c11b", async() => {
                BeginContext(2257, 11, true);
                WriteLiteral("--可根据品牌搜索--");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2277, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 49 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Import.cshtml"
                          
                            foreach (var item in Model.codeList)
                            {

#line default
#line hidden
            BeginContext(2404, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2436, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05a2e4baaa87462194259f5b2511c766", async() => {
                BeginContext(2464, 9, false);
#line 52 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Import.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 52 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Import.cshtml"
                                   WriteLiteral(item.Guid);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2482, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 53 "D:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Stock\Import.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(2542, 10340, true);
            WriteLiteral(@"                    </select>
                </div>
                <button type=""button"" class=""layui-btn layui-btn-sm"" data-type=""toolSearch"">
                    <i class=""layui-icon layui-icon-search""></i> 搜索
                </button>
            </div>
            <table class=""layui-hide"" id=""tablist"" lay-filter=""tool""></table>
        </div>
    </div>   
    <script type=""text/html"" id=""toolbar"">
        <div class=""layui-btn-container"">
            <button type=""button"" class=""layui-btn layui-btn-sm"" lay-event=""toolAdd""><i class=""layui-icon""></i> 新增</button>
            <button type=""button"" class=""layui-btn layui-btn-sm"" lay-event=""toolDel""><i class=""layui-icon""></i> 删除</button>
        </div>
    </script>
    <script>
        var funTool,vm = new Vue({
            el: ""#app"",
            data: {
                list: [],
                curModel: {},
                activeName:''
            },
            methods: {
                selected: function (m) {
            ");
            WriteLiteral(@"        this.activeName = m;
                },
                getList: function (m) {
                    funTool.getGoodsSku(m);
                },
                tools: function (m, event) {
                    this.curModel = m;
                    funTool.tool(event);
                },
                edit: function () {
                    funTool.edit();
                },
                deletes: function () {
                    funTool.deletes();
                }
            }
        });           
        layui.config({
            base: '/themes/js/modules/'
        }).use(['table', 'layer', 'jquery', 'common', 'form', 'laydate'],
            function () {
                var table = layui.table,
                    layer = layui.layer,
                    $ = layui.jquery,
                    os = layui.common,
                    laydate = layui.laydate,
                    form = layui.form;
                form.render('select');
                laydate.render({");
            WriteLiteral(@"
                    elem: '#times'
                    , theme: '#393D49'
                    , format: 'yyyy/MM/dd'
                    , range: true
                });
                $(""ul.fyt-utree"").css({ 'height': $(window).height() - 130 });
                table.render({
                    toolbar: '#toolbar',
                    elem: '#tablist',
                    url: '/api/stock/inoutlist',
                    cols: [
                        [
                            { type: 'checkbox', fixed: 'left' },
                            { field: 'code', width:200, title: '条形码',  fixed: 'left' },
                            { field: 'brankName', title: '品牌' },
                            { field: 'styleName', title: '款式' },
                            { field: 'stockSum', width: 150, title: '入库数量', sort: true },
                            { field: 'addDate', title: '添加时间' },
                            { width: 100, title: '操作', templet: '#tool' }
                        ]
 ");
            WriteLiteral(@"                   ],
                    page: { limits: [10, 20, 50, 100, 500, 1000, 5000, 10000], groups: 8 },
                    limit: 15,
                    id: 'tables'
                });

                $(document).click(function (e) {
                    var _target = $(e.target);
                    if (_target.closest("".fyt-task-menu"").length == 0) {
                        $("".fyt-task-menu"").addClass('layui-hide');
                    }                    
                });

                
                var packguid='', active = {                    
                    reload: function () {
                        table.reload('tables',
                            {
                                page: {
                                    curr: 1
                                },
                                where: {
                                    packGuid: packguid,
                                    types: 1,
                                    gui");
            WriteLiteral(@"d: $('#shops').val(),
                                    key: $('#key').val(),
                                    brank: $('#branks').val()
                                }
                            });
                    },
                    toolSearch: function () {
                        active.reload();
                    },
                    addIn: function () { 
                        os.Open('添加入库单', '/fytadmin/stock/packlog/?types=1', '600px', '400px', function () {
                            funTool.packPage();
                        });
                    },
                    toolAdd: function () {
                        if (packguid === '') {
                            os.warning('请选择入库单~');
                            return;
                        }
                        os.Open('添加入库信息', '/fytadmin/stock/importmodify/?packguid=' + packguid, '600px', '350px', function () {
                            active.reload();
                        });
       ");
            WriteLiteral(@"             },
                    toolDel: function () {
                        var checkStatus = table.checkStatus('tables')
                            , data = checkStatus.data;
                        if (data.length === 0) {
                            os.warning(""请选择要删除的项目~"");
                            return;
                        }
                        var str = '';
                        $.each(data, function (i, item) {
                            str += item.guid + "","";
                        });
                        layer.confirm('确定要执行批量删除吗？', function (index) {
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']
                            });
                            os.ajax('api/stock/delinout/', { parm: str }, function (res) {
                                layer.close(loadindex);
                                if (res.statusCode === 200) {
     ");
            WriteLiteral(@"                               active.reload();
                                    os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }
                            });
                        });

                    }
                };                

                funTool = {
                    getGoodsSku: function (obj) {
                        packguid = obj.guid;
                        active.reload();
                    },
                    packPage: function () {
                        os.ajax('api/stock/packloglist', { types: 1, time: $('#times').val(), guid: $('#shops').val(), key: $('#key').val() }, function (res) {
                            if (res.statusCode === 200) {
                                vm.list = res.data.items;
                            } else {
                                os.error(res.message);
                            }
              ");
            WriteLiteral(@"          });
                    },
                    edit: function () {
                        $("".fyt-task-menu"").addClass('layui-hide');
                        os.Open('修改入库单', '/fytadmin/stock/packlog/?guid=' + vm.curModel.guid, '600px', '400px', function () {
                            funTool.packPage();
                        });
                    },
                    deletes: function () {
                        $("".fyt-task-menu"").addClass('layui-hide');
                        layer.confirm('确定要执行批量删除吗？', function (index) {
                            layer.close(index);
                            var loadindex = layer.load(1, {
                                shade: [0.1, '#000']
                            });
                            os.ajax('api/stock/delpacklog/', { parm: vm.curModel.guid }, function (res) {
                                layer.close(loadindex);
                                if (res.statusCode === 200) {
                                    ");
            WriteLiteral(@"funTool.packPage();
                                    os.success('删除成功！');
                                } else {
                                    os.error(res.message);
                                }
                            });
                        });
                    },
                    tool: function (event) {
                        event.stopPropagation();
                        event.preventDefault();
                        var obj = $(event.target).offset();
                        $("".fyt-task-menu"").css({ 'top': obj.top - 30, 'left': '275px' });
                        if ($('.fyt-task-menu').hasClass('layui-hide')) {
                            $("".fyt-task-menu"").removeClass('layui-hide');
                        } else {
                            $("".fyt-task-menu"").addClass('layui-hide');
                        }
                    }
                };
                //初始化入库单管理
                funTool.packPage();

                $(""#addIn"").o");
            WriteLiteral(@"n('click', function () {
                    active.addIn();
                });
                table.on('toolbar(tool)', function (obj) {
                    active[obj.event] ? active[obj.event].call(this) : '';
                });
                $('.list-search .layui-btn').on('click', function () {
                    var type = $(this).data('type');
                    active[type] ? active[type].call(this) : '';
                    funTool.packPage();
                });
                //监听工具条
                table.on('tool(tool)', function (obj) {
                    var data = obj.data;
                    if (obj.event === 'edit') {
                        os.Open('修改入库信息', '/fytadmin/stock/importmodify/?guid=' + data.guid, '600px', '350px', function () {
                            active.reload();
                        });
                    }
                });
            });
    </script>
    <script type=""text/html"" id=""tool"">
        <a class=""layui-btn layui-btn-");
            WriteLiteral("primary layui-btn-xs\" lay-event=\"edit\"><i class=\"layui-icon\"></i> 修改</a>\r\n    </script>\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Stock.ImportModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Stock.ImportModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Stock.ImportModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Stock.ImportModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
