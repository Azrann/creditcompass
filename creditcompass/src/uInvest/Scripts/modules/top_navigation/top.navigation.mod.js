App.module("TopNavigation", function (TopNavigation, $, Backbone, Marionette) {
    TopNavigation.Layout = Marionette.Layout.extend({
        template: "top_navigation/templates/top_navigation_layout",
        regions: {
            navBarRegion: "#top-navigation"
        }
    });

    TopNavigation.InputView = Marionette.ItemView.extend({
        template: "top_navigation/templates/top_navigation_view"
    });

    TopNavigation.on("start", function () {
        var layout = new TopNavigation.Layout();
        var view = new TopNavigation.InputView();

        App.navRegion.show(layout);

        layout.navBarRegion.show(view);
    });



    App.on("initialize:after", function () {
        App.module("TopNavigation").start();
    });
});