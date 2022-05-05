// dışardan gönderilen form elamanını json'a çevirir
const convertFormDataToJson = (formEl) => {
    const formData = new FormData(formEl);
    const formJSON = Object.fromEntries(formData);
    return formJSON;
};