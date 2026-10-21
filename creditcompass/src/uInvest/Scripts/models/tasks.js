App.module("Models.Task", function (Task, $, Backbone, Marionette) {

    Task.TaskItem = Backbone.Model.extend({
        defaults: {
            name: "",
            section: ""
        }
    });

    Task.TaskCollection = Backbone.Collection.extend({
        model: Task.TaskItem
    });

    var tasks = new Task.TaskCollection();

    App.reqres.setHandler("tasks:entities", function () {
        return tasks;
    });

});