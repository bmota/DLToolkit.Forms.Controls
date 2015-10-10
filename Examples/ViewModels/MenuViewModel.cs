﻿using System;
using DLToolkit.PageFactory;

namespace Examples.ViewModels
{
	public class MenuViewModel : BaseViewModel
	{
		public MenuViewModel()
		{
			FlowListViewDemoCommand = new PageFactoryCommand(() => 
				PageFactory.GetMessagablePageFromCache<FlowListViewViewModel>()
				.SendMessageToViewModel("FillWithData")
				.PushPage());
		}

		public IPageFactoryCommand FlowListViewDemoCommand { get; private set; } 
	}
}

