//<script>
bouncex.tryCatch(function reloadCampaigns(){
	var newCampaigns = false;
	bouncex.creatives = false;
	bouncex.brandStyles = false;
	bouncex.webfonts = false;

	if (bouncex.gbi) {
		bouncex.gbi.stacks = false;
	}

	var newCookie = {"v":{"submitted_onsite":false,"submitted_email_daily":false,"submitted_email_royals":false,"submitted_email_runway":false,"submitted_email_beauty":false,"submitted_email_theget":false,"ever_logged_in":false,"ccpa_cali":"true"},"fvt":1610077613,"vid":1610077613317916,"ao":0,"lp":"https%3A%2F%2Fwww.vogue.com%2Farticle%2Fbridgerton-costumes%3Futm_source%3Dnl%26utm_brand%3Dvogue%26utm_mailing%3DVOG_Daily_010121%26utm_campaign%3Daud-dev%26utm_medium%3Demail%26bxid%3D5db3c4fcb43a614cbf28ae97%26cndid%3D59019216%26hasha%3Da009694484beecbed985e2a72f516cfa%26hashb%3Da856670edbe7b0a93c058cc26b654c3d97045bd6%26hashc%3D701b139813fd6a36bb26b7f297e976deacff1965fb43c1ad9c4261f7d2084228%26esrc%3DbounceX%26utm_content%3DFinal%26utm_term%3DVOG_Daily","as":0,"vpv":1,"d":"d","r":"","cvt":1610077613,"sid":1,"gcr":56,"m":0,"did":"8528778908731809895","lvt":1610077613,"hc_VOGDaily":1,"hc_utmmailingvogdaily":1};	
	var campaignAdded = false;
	for (var campaignId in newCampaigns) {
		if (newCampaigns.hasOwnProperty(campaignId)) {
			// if campaign cookie does not exist
			if (!bouncex.cookie.campaigns) {
				bouncex.cookie.campaigns = {};
			}
			if (!bouncex.cookie.campaigns[campaignId]) {
				campaignAdded = true;
				bouncex.cookie.campaigns[campaignId] = {lvt:bouncex.cookie.lvt, vv:0};
			} else if (newCookie.campaigns[campaignId]) {
				// need to set campaign cookie's activations_sessions to the new cookie as it gets modified in reloadCampaigns
				campaignAdded = true;
				bouncex.cookie.campaigns[campaignId].as = newCookie.campaigns[campaignId].as;
			}
		}
	}
	if (campaignAdded) {
		bouncex.setBounceCookie();
	}

	for (var campaignId in bouncex.campaigns) {
		if (bouncex.campaigns.hasOwnProperty(campaignId)) { //copy state vars
			if (newCampaigns[campaignId]) {
				newCampaigns[campaignId].ap = bouncex.campaigns[campaignId].ap;
				newCampaigns[campaignId].repressed = Boolean(bouncex.campaigns[campaignId].repressed);
			}

			if (newCampaigns[campaignId] &&
				bouncex.campaigns[campaignId].ad_visible &&
				newCampaigns[campaignId].html.replace(/fsa=(\d+)&|width=(\d+)&|height=(\d+)&/gi,'') == bouncex.campaigns[campaignId].html.replace(/fsa=(\d+)&|width=(\d+)&|height=(\d+)&/gi,'')) {
								newCampaigns[campaignId] = bouncex.campaigns[campaignId];
			} else if (newCampaigns[campaignId] && bouncex.isGbi2Campaign(campaignId) && bouncex.campaigns[campaignId].gbi.hasBegunAuction) {
								newCampaigns[campaignId] = bouncex.campaigns[campaignId];
			} else {
				bouncex.destroy_ad(campaignId);
			}
		}
	}

	bouncex.campaigns = newCampaigns;
	newCampaigns = {};

	bouncex.debug = false;
		bouncex.setBounceCookie();
	if (bouncex.campaigns) {
		for (var campaignId in bouncex.campaigns) {
			if (bouncex.campaigns[campaignId].ad_visible && typeof bouncex.repressCampaigns === 'function') {
				bouncex.repressCampaigns(campaignId);
			}
		}
		bouncex.loadBounceCss(bouncex.initActivationFuncs);
	}
		bouncex.loadBrandStyles();
	bouncex.loadWebfonts();

	})();
