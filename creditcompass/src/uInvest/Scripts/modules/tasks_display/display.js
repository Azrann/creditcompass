App.module("TasksDisplay", function (TasksDisplay, $, Backbone, Marionette) {

    TasksDisplay.TaskItemView = Marionette.ItemView.extend({
        tagName: "li",
        template: "tasks_display/templates/display_item_view",

        events: {
            "click #btn-remove": "remove"
        },

        remove: function () {
            console.log("remove");
        }
    });

    TasksDisplay.TaskCollectionView = Marionette.CollectionView.extend({
        itemView: TasksDisplay.TaskItemView,
        tagName: "ul"
    });

    TasksDisplay.on("start", function () {
        var view = new TasksDisplay.TaskCollectionView({
            collection: App.request("tasks:entities")
        });

        App.bottomRegion.show(view);
    });



    App.on("initialize:after", function () {
        App.module("TasksDisplay").start();
    });

});