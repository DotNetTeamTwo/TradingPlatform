/**
 * Created by Demon on 2017/8/9.
 */

//table color change depend on td content
$("#orderHistory tr:gt(0)").each(function(i){
    //alert("这是第"+i+"行内容");
    $(this).children("td").each(function(i){
        //alert("第"+i+"个td的内容："+$(this).text());

        if($(this).text()=="Completed"){
            $(this).parent().addClass("success");
        }else if($(this).text()=="Processing"){
            $(this).parent().addClass("active");
        }else if($(this).text()=="Rejected"){
            $(this).parent().addClass("danger");
        }
    });
});