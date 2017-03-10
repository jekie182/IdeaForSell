var lastParsedObject;

function isJsonResult(data)
{
    try
    {
        lastParsedObject = JSON.parse(data);
    }
    catch (e)
    {
        return false;
    }
    return true;
}

function showModalMessage()
{
    if(lastParsedObject != null)
    {
        var innerHTML;
        if (lastParsedObject.IsSuccess)
            innerHTML = getSuccessHTML();
        else
            innerHTML = getErrorHTML();

        var elemDiv = document.createElement('div');
        elemDiv.id = "ModalMessageContainer";
        elemDiv.innerHTML = innerHTML;
        document.body.appendChild(elemDiv);
    }
}

function getSuccessHTML()
{
    if(lastParsedObject.Message != null)
    {
        //show succes message
        return '<div aria-hidden="false" aria-labelledby="myModalLabel" role="dialog" tabindex="-1" id="myModal" class="modal fade in" style="display: block;">'
              + '<div class="modal-dialog">'
               + ' <div class="modal-content">'
                     + '<div class="modal-header">'
                          + '<button type="button" class="close" data-dismiss="modal" aria-hidden="true" onclick = "deleteModalWindow()">&times;</button>'
                          + '<h4 class="modal-title">Error</h4>'
                      + '</div>'
                      + '<div class="modal-body">'
                          +'<div class="alert alert-success"><b>'+ lastParsedObject.Message +'</b></div>'
                      + '</div>'
                      + '<div class="modal-footer">'
                          + '<button data-dismiss="modal" class="btn btn-default" onclick = "deleteModalWindow()" type="button">Ok</button>'
                      + '</div>'
                  + '</div>'
              + '</div>'
          + '</div>'
    }
        //show an info message list
    else
    {
        var messageList = '';
        if(lastParsedObject.Result != null)
        {
            lastParsedObject.Result.forEach(function(entry) {
                messageList += '<div class="alert alert-info"><b> '+ entry  +'</b></div>';
            });
        }

        return '<div aria-hidden="false" aria-labelledby="myModalLabel" role="dialog" tabindex="-1" id="myModal" class="modal fade in" style="display: block;">'
              + '<div class="modal-dialog">'
               + ' <div class="modal-content">'
                     + '<div class="modal-header">'
                          + '<button type="button" class="close" data-dismiss="modal" aria-hidden="true" onclick = "deleteModalWindow()">&times;</button>'
                          + '<h4 class="modal-title">Error</h4>'
                      + '</div>'
                      + '<div class="modal-body">'
                          + messageList
                      + '</div>'
                      + '<div class="modal-footer">'
                          + '<button data-dismiss="modal" class="btn btn-default" onclick = "deleteModalWindow()" type="button">Ok</button>'
                      + '</div>'
                  + '</div>'
              + '</div>'
          + '</div>'
    }
    }
}

function getErrorHTML()
{
    if (lastParsedObject.Message != null) {
        //show an error
        {
            return '<div aria-hidden="false" aria-labelledby="myModalLabel" role="dialog" tabindex="-1" id="myModal" class="modal fade in" style="display: block;">'
              + '<div class="modal-dialog">'
               + ' <div class="modal-content">'
                     + '<div class="modal-header">'
                          + '<button type="button" class="close" data-dismiss="modal" aria-hidden="true" onclick = "deleteModalWindow()">&times;</button>'
                          + '<h4 class="modal-title">Error</h4>'
                      + '</div>'
                      + '<div class="modal-body">'
                            +'<div class="alert alert-danger"><b>'+lastParsedObject.Message+'</b></div>'
                      + '</div>'
                      + '<div class="modal-footer">'
                          + '<button data-dismiss="modal" class="btn btn-default" onclick = "deleteModalWindow()" type="button">Ok</button>'
                      + '</div>'
                  + '</div>'
              + '</div>'
          + '</div>'
        }
    }
        //show warning message
    else {
        var messageList = '';
        if(lastParsedObject.Result != null)
        {
            lastParsedObject.Result.forEach(function(entry) {
                messageList += '<div class="alert alert-warning"><b> '+ entry  +'</b></div>';
            });
        }

        return '<div aria-hidden="false" aria-labelledby="myModalLabel" role="dialog" tabindex="-1" id="myModal" class="modal fade in" style="display: block;">'
              + '<div class="modal-dialog">'
               + ' <div class="modal-content">'
                     + '<div class="modal-header">'
                          + '<button type="button" class="close" data-dismiss="modal" aria-hidden="true" onclick = "deleteModalWindow()">&times;</button>'
                          + '<h4 class="modal-title">Error</h4>'
                      + '</div>'
                      + '<div class="modal-body">'
                          + messageList
                      + '</div>'
                      + '<div class="modal-footer">'
                          + '<button data-dismiss="modal" class="btn btn-default" onclick = "deleteModalWindow()" type="button">Ok</button>'
                      + '</div>'
                  + '</div>'
              + '</div>'
          + '</div>'
    }
}

function deleteModalWindow()
{
    $('#ModalMessageContainer').remove();
}