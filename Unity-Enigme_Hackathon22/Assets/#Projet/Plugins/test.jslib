
mergeInto(LibraryManager.library, {
    
    GetTextValue: function () {
        
        let message = window.GetMessage();
        var bufferSize = lengthBytesUTF8(message) + 1;
        var buffer = _malloc(bufferSize);

        stringToUTF8(message, buffer, bufferSize);
        console.log(message);
        
        return buffer;
    },
    
    
});